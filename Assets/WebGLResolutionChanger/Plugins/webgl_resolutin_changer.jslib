mergeInto(LibraryManager.library, {
    SetCanvasResolutionJS: function (width, height) {
        var canvas = document.getElementById("unity-canvas");
        canvas.width = width;
        canvas.height = height;
        canvas.style.width = width + "px";
        canvas.style.height = height + "px";
    }
});
