﻿$(window).on('load', function(){
    var video = document.getElementById('video');
    var canvas = document.getElementById('canvas');
    var canvasImage = document.getElementById('mat-truoc-canvas');
    var context = canvas.getContext('2d');
    var imgUrl = document.getElementById("imgUrl").src;
    var img = new Image();
    img.src = imgUrl;

    var tracker = new tracking.ColorTracker();

    tracking.track('#video', tracker, { camera: true });

    tracker.on('track', function (event) {
        context.clearRect(0, 0, canvas.width, canvas.height);

        event.data.forEach(function (rect) {
            if (rect.color === 'custom') {
                rect.color = tracker.customColor;
            }
            context.clearRect(0, 0, canvas.width, canvas.height);
            context.drawImage(img, rect.x - (rect.x / 2),rect.y);
            context.strokeStyle = rect.color;
            context.strokeRect(rect.x, rect.y, rect.width, rect.height);
            context.font = '11px Helvetica';
            context.fillStyle = "#fff";
            context.fillText('x: ' + rect.x + 'px', rect.x + rect.width + 5, rect.y + 11);
            context.fillText('y: ' + rect.y + 'px', rect.x + rect.width + 5, rect.y + 22);
        });
    });

    initGUIControllers(tracker);
})