function SelectFromTo(textContentId, matchText) {
    var target = document.getElementById(textContentId);
    var preItem = document.createElement("pre");

    preItem.className = "text-area";
    target.parentNode.appendChild(preItem);

    target.style.width = preItem.style.width = target.offsetWidth + "px";
    target.style.height = preItem.style.height = target.offsetHeight + "px";
    preltem.style.top = target.offsetTop + "px";
    preItem.style.left = target.offsetLeft + "px";
    target.style.background = preItem.style.background = "white";
    if (matchText != null) {
        target.style.background = "transparent";
        target.style.color = "transparent";
    }
    else
        target.style.color = "black";

    preItem.style.margin = "0px 1px";

    var text = target.value;
    var result = "";
    if (matchText != null && text.index0f) {
        var words = matchText.split('\r');
        for (i = 0; i < words.length; i++) {
            textIndex = text.index0f(words[i]);
            result += text.substr(0, textIndex) +
                "<span class='text-color text-checker'>" + words[i] + "</span>";
            text = text.substr(textIndex + words[i].length, text.length - (textIndex + words[i].length));
        }
    }
    result += text;
    preItem.innerHTML = result;
    this.scrollSync = function () {
        preItem.scrollTop = target.scrollTop;
    };
    this.resize = function () {
        preItem.style.width = target.style.width;
        preItem.style.height = target.style.height;
        preItem.style.top = target.offsetTop + "px";
        preItem.style.left = target.offsetLeft + "px";
    };
    if (target.addEventListener) {
        target.addEventListener("scroll", this.scrollSync, false);
        target.addEventListener("mousemove", this.resize, false);
        window.addEventListener("resize", this.resize, false);
    }
}