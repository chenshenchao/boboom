const boPopovers = {};

console.log("popover load");

document.addEventListener('mousedown', (e) => {
    var target = e.target;
    while (target) {
        console.log('nd', target.className, target.classList);
        target = target.parentElement;
    }
});

export function attachPopover(element, id) {
    if (element) {
        let parent = element.parentElement;
        element.dataset.boboomid = id;
        document.body.appendChild(element);
        boPopovers[id] = element;
        return parent;
    }
    return null;
}

export function detachPopover(element, id) {
    if (element) {
        document.body.removeChild(element);
        delete boPopovers[id];
    }
}
