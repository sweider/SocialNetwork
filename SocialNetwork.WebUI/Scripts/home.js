$(document).ready(function () {

    $(".new-comment-link").on("click", ".comment-trigger", function () {
        var commentPart = $(this).closest(".media-body").find(".comment-adding-part");
        commentPart.toggleClass("hidden");
        commentPart.find(".new-comment-textarea").focus();
    });

    $(".first-comment-textarea").on("focusout", function () {
        $(this).closest(".comment-adding-part").toggleClass("hidden");
    });

    $(".new-comment_non-focused").on("focusin focusout", ".new-comment-textarea", function () {
        $(this).closest(".comment-adding-part").toggleClass("new-comment_non-focused");
    });
});

