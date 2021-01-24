jQuery( document ).ready( function($){



    var lastScrollTop = 0,st, direction;
    function detectDirection() {
        st = window.pageYOffset;
        if (st > lastScrollTop) {
            direction = "down";
        } else {
            direction = "up";
        }
        lastScrollTop = st;
        return direction;
    }



    $('.full_width_main_menu, #sticky_product_tabs').css({
        'top': $('header#header_newkala').height()
    });



    $(window).bind('scroll', function() {
        var dir = detectDirection();
        var catMenu = $('.full_width_main_menu');
        var top = $('header#header_newkala').height();
        if (dir === 'down') {
            catMenu.css({
                'top': top - catMenu.height()
            });
        } else if (dir === 'up') {
            catMenu.css({
                'top': top
            });
        }
    });



    setTimeout(function(){
        $('.full_width_main_menu, #sticky_product_tabs').css({
            'top': $('header#header_newkala').height()
        });
    }, 5000);


    $('.mega-menu-toggle-block, .newkala_menu_icon_shop').on('click', function(){

        $('.black_opacity_responsive_menu, .main_newkala_responsive_menu').addClass('show');
    });
    $('.black_opacity_responsive_menu').on('click', function(){

        $('.black_opacity_responsive_menu, .main_newkala_responsive_menu').removeClass('show');
        $('.mega-menu-toggle').removeClass('mega-menu-open');
    });


    jQuery('.responsive_main_menu li.menu-item-has-children').append('<span class="toggle_menu"></span>');
    jQuery('.responsive_main_menu li.menu-item-has-children span.toggle_menu').click(function(){
        jQuery(this).parent().find('ul:first').toggleClass('show');
        jQuery(this).toggleClass("opened");
    });

    /*
    var data = {
        'action': 'get_html_responsive_menu'
    };
    jQuery.post(ajax_url, data, function(response) {
        $('.main_newkala_responsive_menu').html(response);
    });
    */








    if ( $('.price_label').length ){
        setTimeout(function(){

            var text = $('.price_label').html();
            text = text.replace("قیمت:", "");
            $('.price_label').html(text);
        }, 300)
    }


    if ( $('.button_display_order_by').length ){

        $('.button_display_order_by').on('click', function(){

            $('.main_custom_order_by_sort, .opacity_black_cover_for_order_by_product').fadeIn(100);
        });
        $('.opacity_black_cover_for_order_by_product').on('click', function(){

            $('.main_custom_order_by_sort, .opacity_black_cover_for_order_by_product').fadeOut(100);
        });
    }

    if ( $('.button_display_filter_product').length ){

        $('.button_display_filter_product').on('click', function(){

            $('.sidebar_archive_product').fadeIn(100);
        });
        $('.responsive_title_filters span').on('click', function(){

            $('.sidebar_archive_product').fadeOut(100);
        });
    }
    /**
     *--------------------------------------------------------------------------
     * index layout controller
     *--------------------------------------------------------------------------
     */
    //$('.index_main_header__top___left').remove();
    //$('.index_main_header__top___right').remove();
    //$('.index_main_header__bottom___left').remove();
    //$('.index_main_header__bottom___right').remove();
    /*
        var tmp_top_left 		= $('div').hasClass('index_main_header__top___left');
        var tmp_top_right 		= $('div').hasClass('index_main_header__top___right');
        var tmp_bottom_right 	= $('div').hasClass('index_main_header__bottom___right');
        var tmp_bottom_left		= $('div').hasClass('index_main_header__bottom___left');
        var index_top_left 		= $('.index_main_header__top___left');
        var index_top_right 	= $('.index_main_header__top___right');
        var index_bottom_right 	= $('.index_main_header__bottom___right');
        var index_bottom_left 	= $('.index_main_header__bottom___left');
    
        // check if top left slider not exists then make top main header none
        if(tmp_top_left) {
            //
        } else {
            $('.index_main_header_top').remove();
            $('.main_short_link_by_icon').css('margin-top','0px')
        }
        // check if top right banner not exists then make main slider wide
        if(tmp_top_right) {
            //
        } else {
            index_top_left.css('width','100%');
            index_top_left.css('height','400px');
            $('.flexslider .slides img').css('height','400px')
            $('.index_main_header_top').css('margin-bottom','15px');
            $('.main_short_link_by_icon').css('margin-top','0px')
        }
        // check if slider offerse not exists then make ups icons wide
        if(tmp_bottom_left) {
            //
        } else {
            $('body.home .main_short_link_by_icon').css({
                'margin-top':'0px',
                'width':'100%',
                'display':'flex',
                'flex-flow':'row nowrap',
                'justify-content':'flex-start',
                'align-items':'center',
            });
            $('.main_short_link_by_icon a').css('flex','100%');
            index_bottom_right.css({
                'margin-top':'0px',
                'width':'100%',
            });
            $('.main_slider_side_banner img').height(416);
        }
        // check if ups icons not exists then make slider offerse wide
        if(tmp_bottom_right) {
            //
        } else {
            $('.main_slider_side_banner img').height(416);
            index_bottom_left.css('width','100%');
        }
        */
    /**
     *--------------------------------------------------------------------------
     * go top
     *--------------------------------------------------------------------------
     */
    $('#smoothup').on('click', function(){
        $('html, body').animate({scrollTop:0}, 700);
        return false;
    });
    /**
     *--------------------------------------------------------------------------
     * price lang
     *--------------------------------------------------------------------------
     */
    $('span.price').attr("lang", "fa");
    /**
     *--------------------------------------------------------------------------
     * tablinks
     *--------------------------------------------------------------------------
     */
    if ( $('li.tablinks').length )  $('li.tablinks')[0].click();
    /**
     *--------------------------------------------------------------------------
     * archive product filter
     *--------------------------------------------------------------------------
     */
    $('.widget_layered_nav_filters').addClass('woocommerce-widget-layered-nav');
    /**
     *--------------------------------------------------------------------------
     * waitlist
     *--------------------------------------------------------------------------
     */
    var is_outofstock_product = $('div').hasClass('outofstock');
    if(is_outofstock_product) {
        // add yith waitlist form to modal content
        $('#yith-wcwtl-output').appendTo('.modal_wcwtl_content');
        // change position of related product when ran out of stock
        //$('div.woocommerce.main_product').prependTo('.related_product_in_top');
        $('#yith-wcwtl-output').css('padding-top','100px');
        $('div.woocommerce.main_product').css('margin-top','20px');
        $('#yith-wcwtl-email').css({
            'width':'100%',
            'margin-top':'15px',
        })
    }
    /**
     *--------------------------------------------------------------------------
     * search
     *--------------------------------------------------------------------------
     */
    /*
   
       $('#txt_search').click(function(e) {
           e.stopPropagation();
           $(".main_top_word_search").fadeIn(100);
       });
       $(document).click(function(e) {
           if (!$(e.target).closest('#txt_search').length) {
               $(".main_top_word_search").fadeOut(100);
           }
       });
   
       */

    /**
     *--------------------------------------------------------------------------
     * register - login
     *--------------------------------------------------------------------------
     */
    $('.title_login_register').click(function(e) {
        e.stopPropagation();
        $(".main_content_login_register").fadeIn(50);
    });
    $(document).click(function(e) {
        if (!$(e.target).closest('.title_login_register').length) {
            $(".main_content_login_register").fadeOut(50);
        }
    });
    /**
     *--------------------------------------------------------------------------
     * dokan
     *--------------------------------------------------------------------------
     */
    // dokan store single tabs
    $('.store_trigger').click(function(){
        // trigr activation
        var trigger_index = $(this).index();
        $('.store_trigger.store_active').removeClass('store_active');
        $(this).toggleClass('store_active');
        // content activation
        $('.store_content.store_active').removeClass('store_active');
        $('.store_content').eq(trigger_index).toggleClass('store_active');
    });
    // dokan rating stars
    $('.dokan-rating').each(function(){
        $(this).addClass('woocommerce');
    });
    // dokan product single - vendors comparison
    //$('.dokan-other-vendor-camparison-table .table-row:first-child').before("<div class='table-row table-row-titles'><div class='table-cell'>فروشنده</div><div class='table-cell'>قیمت</div><div class='table-cell'>امتیاز فروشنده</div><div class='table-cell'>عملیات</div></div>");

    /**
     *--------------------------------------------------------------------------
     * blog comments
     *--------------------------------------------------------------------------
     */
    $('body.single-post #commentform').fadeOut();
    $('.title_box_single , .reply').click(function() {
        $('body.single-post #commentform , body.single-post  .respond').fadeToggle();
    });
    $('body.single-product #commentform').fadeIn();
    /**
     *--------------------------------------------------------------------------
     * archive product
     *--------------------------------------------------------------------------
     */

    if ( $('.woocommerce-widget-layered-nav-list').length ){

        $('.title-widget-archive-product').on( 'click', function(){
            $(this).next('.woocommerce-widget-layered-nav-list').slideToggle(400);
        });

        $('.widget_layered_nav.woocommerce-widget-layered-nav ul li a').on( 'click', function(){
            $('.onliner_main_loading').fadeIn(400);
        });


        jQuery('li.chosen').parent().show(0);

    }




    // type of view
    if($( "ul.products" ).hasClass("listing_view"))
        $('p.archive_product_subtitle').show();
    else
        $('p.archive_product_subtitle').hide();
    $('.type_view_listing').click(function(){ $('p.archive_product_subtitle').show(); });
    $('.type_view_grid').click(function(){ $('p.archive_product_subtitle').hide(); });

    $('.type_view').on( 'click', function(){

        $('.type_view').removeClass('active');
        $(this).addClass('active');

        var type_view = $(this).attr('type_view');

        if ( type_view == 'listing' ){

            $('ul.products').addClass('listing_view');

        } else if ( type_view == 'grid' ){

            $('ul.products').removeClass('listing_view');
        }

        $.post( ajax_url ,
            {
                action: "choose_type_view",
                type_view : $(this).attr('type_view'),
            },
            function(data, status){
                //alert("Data: " + data + "\nStatus: " + status);
            });

    });

    /*
        // yith compare - action buttons structures
        $(".yith-woocompare-widget a.clear-all").appendTo(".cfw_buttons");
        $(".yith-woocompare-widget a.compare-widget").appendTo(".cfw_trigger");
        $('a.clear-all').text('انصراف');
        // yith compare - counter init
        $('.compare-widget').before('<span class="compare_title">مقایسه</span>');
        var compare_items  = $(".cfw_content ul").children().length;
        if($(".cfw_content ul li:first-child").hasClass('list_empty')) {
            compare_items--;
            $('a.compare-widget').text(' ۰ کالا ');
        }
        else {
            var compare_items  = $(".cfw_content ul").children().length;
            $('a.compare-widget').text(compare_items+' کالا ');
        }
        if(compare_items == 0)
            $('.cfw_trigger , .cfw_wrapper').fadeOut();
        // yith compare - counter add
        $('.compare-button a.compare , a.compare.button').click(function(){
            if(compare_items == 0 ) {
                var compare_title = $('a.compare-widget').text();
                compare_items++;
                $('a.compare-widget').text(compare_items+' کالا ');
            }
            else {
                compare_items  = $(".cfw_content ul").children().length;
                compare_title = $('a.compare-widget').text();
                compare_items++
                $('a.compare-widget').text(compare_items+' کالا ');
            }
            // yith compare - show n hide floating widget when noting is for compare
            if(compare_items = 0) {
                $('.cfw_trigger , .cfw_wrapper').fadeOut();
            } else {
                $('.cfw_trigger , .cfw_wrapper').fadeIn();
            }
        })
        // yith compare - counter remove all
        $('.clear-all').click(function(){
            compare_items = 0;
            $('a.compare-widget').text('۰ کالا ');
        });
        // yith compare - show n hide
        $(".cfw_trigger").hover(function(){
            $('.cfw_wrapper').css('display','flex');
        },function(){
            $('.cfw_wrapper').css('display','flex');
        });
        $(".cfw_wrapper").hover(function(){
            $('.cfw_wrapper').css('display','flex');
        },function(){
            $('.cfw_wrapper').css('display','none');
        });
        // compare change reset items in widget and return to current page insted of homepage
        var compare_current_url = $(location).attr('href');
        var compare_reset_url = '?action=yith-woocompare-remove-product&id=all'
        var compare_reset_url_new = compare_current_url + compare_reset_url;
        $('.cfw_wrapper .clear-all').attr('href',compare_reset_url_new);
        //yith compare - page
        $('#yith-woocompare-cat-nav h3').text('نمایش مقایسه محصولات بر اساس دسته بندی های مشترک');
        // yith link to compare page
        var compare_page_link = $("a.compare-widget").attr("href");
        $(".cfw_trigger").attr("href",compare_page_link);
        */

    // set image if has set for variable product
    if ( $( ".single_variation_wrap" ).length ) {

        $( ".single_variation_wrap" ).on( "show_variation", function ( event, variation ) {

            if ( variation['image']['src'] ){

                $('.newkala_product_image .wp-post-image').attr('src', variation['image']['src']);
                $('.newkala_product_image .wp-post-image').attr('srcset', variation['image']['srcset']);
                $('.newkala_product_image .wp-post-image').attr('sizes', variation['image']['sizes']);
                $('.newkala_product_image .wp-post-image').attr('data-zoom-image', variation['image']['full_src']);

                var ez =   $('#attachment-shop_single').data('elevateZoom');
                if(ez)
                    ez.swaptheimage(variation['image']['src'], variation['image']['full_src']);

            }



            var has_price_html = jQuery('.woocommerce-variation-price').html();

            if ( has_price_html == '' ){

                var price_html = jQuery('body.single-product .product-type-variable .summary p.price').html();

                jQuery('.woocommerce-variation-price').html( '<span class="price">' + price_html + '</span>' );

            }



        } );
    }




    if ( $( ".single-product .wc-tabs-wrapper" ).length ){

        var stickymenu = document.getElementById("sticky_product_tabs");
        var stickymenuoffset = jQuery('#sticky_product_tabs').offset();
        stickymenuoffset = stickymenuoffset.top;

        $(window).scroll(function() {

            var windowpos = $(window).scrollTop();

            var current_tab = $('.woocommerce-Tabs-panel[style="display: block;"]').height();
            /*
            if (windowpos >= stickymenuoffset & windowpos <= stickymenuoffset + current_tab ) {

                //stickymenu.classList.add('sticky_tab');
                //jQuery('.wc-tabs-wrapper').addClass('sticky_tab_wrapper');
                jQuery('.full_width_main_menu').hide(0);

            } else {

                //stickymenu.classList.remove('sticky_tab');
                //jQuery('.wc-tabs-wrapper').removeClass('sticky_tab_wrapper');
                jQuery('.full_width_main_menu').show(0);
            }*/
        });


        var i = 0;
        jQuery( 'ul.wc-tabs li' ).on( 'click', function(){

            if ( i > 1 ) jQuery('html, body').animate({scrollTop: jQuery('.wc-tabs-wrapper').offset().top}, 'slow');
            i++;
        });

    }




    if ( $( "#nk_top_products_table_compare" ).length ){

        var stickymenu = document.getElementById("nk_top_products_table_compare");
        var stickymenuoffset = jQuery('#nk_top_products_table_compare').offset();
        stickymenuoffset = stickymenuoffset.top;

        $(window).scroll(function() {

            var windowpos = $(window).scrollTop() + 75;

            var current_tab = $('.nk_compare_page').height();

            if (windowpos >= stickymenuoffset & windowpos <= stickymenuoffset + current_tab ) {


                jQuery('#nk_top_products_table_compare').addClass('sticky_compare');
                //jQuery('.full_width_main_menu').hide(0);

            } else {

                jQuery('#nk_top_products_table_compare').removeClass('sticky_compare');
                //jQuery('.full_width_main_menu').show(0);
            }
        });
    }



    //add_to_cart_by_choose_quantity
    jQuery("button.newkala_add_to_cart_button_loop").click(function(){
        jQuery(this).addClass("none");
        jQuery(this).parent().find(".select_quantity").addClass("block");
    });

    jQuery('.select_quantity').on('change', function() {
        var value = $(this).val();
        jQuery(this).parent().find(".ajax_add_to_cart").attr('data-quantity', value);
        jQuery(this).parent().find(".ajax_add_to_cart").click();
    });

    //click to go comments in single product
    jQuery(".product_meta .rating_and_nummbercomment .comments_number p").click(function(){
        jQuery('#tab-title-reviews a').click();
    });


    jQuery("ul.subcategories_list li").addClass("swiper-slide");
    //Swiper subcategories in archive pages
    var swiper = new Swiper('.subcategories', {
        slidesPerView: 8,
        spaceBetween: 10,
        freeMode: true,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        breakpoints: {
            320: {
                slidesPerView: 2,
            },
            480: {
                slidesPerView: 3,
            },
            768: {
                slidesPerView: 4,
            },
            1024: {
                slidesPerView: 5,
            },
            1366: {
                slidesPerView: 6,
            },
            1768: {
                slidesPerView: 7,
            },
        }
    });



});

//toggle content expert in single product
jQuery("button.content_expert_button").click(function(){
    jQuery(this).toggleClass("close");
    jQuery(this).parent().find(".content_expert_text").toggleClass("close_expert_text");
    jQuery(this).parent().toggleClass("close_text_box");
});


/**
 *--------------------------------------------------------------------------
 * ajax search
 *--------------------------------------------------------------------------
 */
jQuery(document).ajaxComplete(function() {
    compare_items  = jQuery(".cfw_content ul").children().length;
    jQuery('.remove').click(function(){
        compare_items--;
        jQuery('a.compare-widget').text(compare_items+' کالا ');
    });
});

/**
 *--------------------------------------------------------------------------
 * load ajax chart price
 *--------------------------------------------------------------------------
 */
function get_price_chart_product( product_id ){

    var data = {
        'product_id': product_id,
        'action': 'product_price_chart'
    };

    jQuery.post(ajax_url, data, function(response) {
        jQuery('#productchartprice').html(response);
    });

    jQuery('span.chart_price').attr('onclick', '');
};

setTimeout(function(){

}, 1000);
