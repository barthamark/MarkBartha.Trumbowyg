(function ($) {
    'use strict';

    $.extend(true, $.trumbowyg, {
        langs: {
            en: {
                insertOrchardMedia: 'Media library',
            }
        },
        plugins: {
            insertOrchardMedia: {
                init: function (trumbowyg) {
                    var btnDef = {
                        ico: 'insertImage',
                        fn: function () {
                            trumbowyg.saveRange();

                            var adminIndex = location.href.toLowerCase().indexOf("/admin/");
                            if (adminIndex === -1) return;
                            var url = location.href.substr(0, adminIndex) + "/Admin/Orchard.MediaLibrary?dialog=true";
                            $.colorbox({
                                href: url,
                                iframe: true,
                                reposition: true,
                                width: "90%",
                                height: "90%",
                                onLoad: function () {
                                    $('html, body').css('overflow', 'hidden');
                                },
                                onClosed: function () {
                                    $('html, body').css('overflow', '');

                                    var selectedData = $.colorbox.selectedData;

                                    if (selectedData == null) // Dialog cancelled, do nothing
                                        return;

                                    for (var i = 0; i < selectedData.length; i++) {
                                        var mediaUrl = location.href.substr(0, adminIndex) + "/Admin/Orchard.MediaLibrary/MediaItem/" + selectedData[i].id + "?displayType=Raw";
                                        $.ajax({
                                            async: false,
                                            type: 'GET',
                                            url: mediaUrl,
                                            success: function (data) {
                                                trumbowyg.range.insertNode($(data)[0]);
                                            }
                                        });
                                    }

                                    trumbowyg.syncTextarea();
                                    trumbowyg.$ed.focus();
                                }
                            });
                        }
                    };

                    trumbowyg.addBtnDef('insertOrchardMedia', btnDef);
                }
            }
        }
    });
})(jQuery);