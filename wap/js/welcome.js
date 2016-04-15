/// <reference path="../Scripts/jquery-1.7.1.min.js" />
$(function () {
    var screenwidth = document.documentElement.clientWidth;
    var $bar = $('#app-bar');
    var $content = $('#app-content');
    var $left = $('#app-content-left');
    var $right = $('#app-content-right');
    var $firstSection = $('#app-first');
    var $secondSection = $('#app-second');
    var $imgQRCode = $('#imgQRCode');
    var grid = screenwidth / 16 * 14;
    var side = screenwidth / 16;
    var tall = '700px';
    $left.css({ 'width': side + 'px', 'height': tall });
    $right.css({ 'width': side + 'px', 'height': tall });
    $content.css({ 'width': grid + 'px', 'height': tall });
    $firstSection.css({ 'width': grid + 'px' });
    $secondSection.css({ 'width': grid + 'px' });
    $imgQRCode.css({ 'width': grid + 'px' });
    $content.addClass('app-top');
});