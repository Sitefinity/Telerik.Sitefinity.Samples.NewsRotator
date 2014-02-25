function switchMode(sender, rotator, direction) {
    if (rotator.autoIntervalID) {
        //refreshButtonsState(sender, rotator)
        window.clearInterval(rotator.autoIntervalID);
        rotator.autoIntervalID = null;
    }
    else {
        //refreshButtonsState(clickedButton, rotator);
        rotator.autoIntervalID = window.setInterval(function () {
            rotator.showNext(direction);
        }, rotator.get_frameDuration());
    }
    refreshButtonsState(sender, rotator);
}


function stopRotator(clickedButton, rotator) {
    if (rotator.autoIntervalID) {
        refreshButtonsState(clickedButton, rotator)
        window.clearInterval(rotator.autoIntervalID);
        rotator.autoIntervalID = null;
    }
}

function showNextItem(clickedButton, rotator, direction) {
    rotator.showNext(direction);
}

// Refreshes the Stop and Start buttons
function refreshButtonsState(clickedButton, rotator) {
    var jQueryObject = $telerik.$;

    var jBtn = jQueryObject(clickedButton);

    if (jBtn.hasClass("rotatorButtonPlay")) {
        jBtn.removeClass("rotatorButtonPlay").addClass("rotatorButtonPause");
    }
    else
    {
        jBtn.removeClass("rotatorButtonPause").addClass("rotatorButtonPlay");
    }
    
   
}

// Finds a button by its className. Returns a jQuery object
function findSiblingButtonByClassName(buttonInstance, className) {
    var jQuery = $telerik.$;
    var ulElement = jQuery(buttonInstance).parent().parent(); // get the UL element
    var allLiElements = jQuery("li", ulElement); // jQuery selector to find all LI elements

    for (var i = 0; i < allLiElements.length; i++) {
        var currentLi = allLiElements[i];
        var currentAnchor = jQuery("A:first", currentLi); // Find the Anchor tag

        if (currentAnchor.hasClass(className)) {
            return currentAnchor;
        }
    }
}
