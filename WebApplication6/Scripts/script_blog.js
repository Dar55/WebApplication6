    $(document).ready(function () {
            var total = $("#img_box img").length;

            $("#imglink1 img").css({
        "border-color": "#0099cc",
                "top": "-5px"
            });

            $(".thumblink").click(function () {
                var imgnumber = parseInt($(this).attr('id').replace("imglink", ""));
                var move = -($("#img" + imgnumber).width() * (imgnumber - 1));

                $("#img_box").animate({
        left: move
                }, 500);

                $("#imgthumb_box").find("img").removeAttr("style");
                $(this).find("img").css({
        "border-color": "#0099cc",
                    "top": "-5px",
                    "border-top-width": "-5px"
                });
                return false;
            });

            $("#navigate a").click(function () {
                var imgwidth = $("#img1").width();
                var box_left = $("#img_box").css("left");
                var el_id = $(this).attr("id");
                var move, imgnumber;

                if (box_left == 'auto') {
        box_left = 0;
    } else {
        box_left = parseInt(box_left.replace("px", ""));
    }

                // if prev
                if (el_id == 'linkprev') {
                    if ((box_left - imgwidth) == -(imgwidth)) {
        move = -(imgwidth * (total - 1));
    } else {
        move = box_left + imgwidth;
    }

                    imgnumber = -(box_left / imgwidth);
                    if (imgnumber == 0) {
        imgnumber = total;
    }
                } else if (el_id == 'linknext') {
                    // if in the last image, move to first
                    if (-(box_left) == (imgwidth * (total - 1))) {
        move = 0;
    } else {
        move = box_left - imgwidth;
    }

                    imgnumber = Math.abs((box_left / imgwidth)) + 2;
                    if (imgnumber == (total + 1)) {
        imgnumber = 1;
    }
                } else if (el_id == 'linkfirst') {
        move = 0;
    imgnumber = 1;
                } else if (el_id == 'linklast') {
        move = -(imgwidth * (total - 1));
    imgnumber = total;
                }

                // styling selected image
                $("#imgthumb_box").find("img").removeAttr("style");
                $("#imglink" + imgnumber).find("img").css({
        "border-color": "#0099cc",
                    "top": "-5px",
                    "border-top-width": "-5px"
                });

                $("#navigate a").hide();

                $("#img_box").animate({
        left: move + 'px'
                }, 400, function () {
        $("#navigate a").show();
    });

                return false;
            });
        });


    $(function() {
        var minBlur = 2,
            maxBlur = 200,
            isUpdatingBlur = false,
            updateBlurStopTimeout = null,
            multiplier = 0.25
            ;

        $.fn.toggleBlur = function (v) {
            var blurId = $(this).data("blur-id");
            var value = v ? "url(#" + blurId + ")" : "none";
            $(this).css({
                webkitFilter: value,
                filter: value
            });
        }
        $.fn.setBlur = function (v) {
            var blur = $(this).data("blur");
            v = Math.round(v);
            if ($(this).data("blur-value") != v) {
                if (v == 0) {
                    $(this).toggleBlur(false);
                } else {
                    $(this).toggleBlur(true);

                    blur.firstElementChild.setAttribute("stdDeviation", v + ",0");
                    $(this).data("blur-value", v);
                }
            }
        }
        $.fn.initBlur = function (_multiplier) {
            if (typeof _multiplier == "undefined") _multiplier = 0.25;
            multiplier = _multiplier;
            var defs = $(".filters defs").get(0);
            var blur = $("#blur").get(0);
            $(this).each(function (i) {
                var blurClone = blur.cloneNode(true);
                var blurId = "blur" + i;
                blurClone.setAttribute("id", blurId);
                defs.appendChild(blurClone);
                $(this)
                    .data("blur", blurClone)
                    .data("blur-id", blurId)
                    .data("blur-value", 0)
                    .data("last-pos", $(this).offset())
                    ;
            });
        }

        $.updateBlur = function () {
            $(".js-blur").each(function () {
                var pos = $(this).offset();
                var lastPos = $(this).data("last-pos");
                var v = Math.abs(pos.left - lastPos.left) * multiplier;
                $(this).data("last-pos", pos);
                $(this).setBlur(v);
            })
            if (isUpdatingBlur) {
                requestAnimationFrame($.updateBlur);
            }
        }
        $.startUpdatingBlur = function (stopDelay) {
            if (typeof stopDelay == "undefined") {
                stopDelay = -1;
            }
            if (updateBlurStopTimeout != null) {
                clearTimeout(updateBlurStopTimeout);
                updateBlurStopTimeout = null;
            }
            if (!isUpdatingBlur) {
                isUpdatingBlur = true;
                $.updateBlur();
            }
            if (stopDelay > -1) {
                updateBlurStopTimeout = setTimeout($.stopUpdatingBlur, stopDelay);
            }
        }
        $.stopUpdatingBlur = function () {
            isUpdatingBlur = false;
        }
    })();

    // Modal Window
    $(document).ready(function () {
        var $modal = $(".modal"),
            $overlay = $(".modal-overlay"),
            blocked = false,
            unblockTimeout = null
            ;

        TweenMax.set($modal, {
            autoAlpha: 0
        })

        var isOpen = false;

        function openModal() {
            if (!blocked) {
                block(400);

                TweenMax.to($overlay, 0.3, {
                    autoAlpha: 1
                });

                TweenMax.fromTo($modal, 0.5, {
                    x: (-$(window).width() - $modal.width()) / 2 - 50,
                    scale: 0.9,
                    autoAlpha: 1
                }, {
                        delay: 0.1,
                        rotationY: 0,
                        scale: 1,
                        opacity: 1,
                        x: 0,
                        z: 0,
                        ease: Elastic.easeOut,
                        easeParams: [0.4, 0.3],
                        force3D: false
                    });
                $.startUpdatingBlur(800);
            }
        }

        function closeModal() {
            if (!blocked) {
                block(400);
                TweenMax.to($overlay, 0.3, {
                    delay: 0.3,
                    autoAlpha: 0
                });
                TweenMax.to($modal, 0.3, {
                    x: ($(window).width() + $modal.width()) / 2 + 100,
                    scale: 0.9,
                    ease: Quad.easeInOut,
                    force3D: false,
                    onComplete: function () {
                        TweenMax.set($modal, {
                            autoAlpha: 0
                        });
                    }
                });
                $.startUpdatingBlur(400);
            }
        }
        function block(t) {
            blocked = true;
            if (unblockTimeout != null) {
                clearTimeout(unblockTimeout);
                unblockTimeout = null;
            }
            unblockTimeout = setTimeout(unblock, t);
        }
        function unblock() {
            blocked = false;
        }
        $(".open-modal").click(function () {
            openModal();
        })
        $(".close-modal,.modal-overlay,.input-submit").click(function () {
            closeModal();
        })

        $modal.initBlur(0.5);

    })