jQuery(function($){var getAttribute=function(attr_name){if(jcaa_attrs===null){return!1}
for(var i=0;i<jcaa_attrs.length;i++){var attr=jcaa_attrs[i];if(attr.name===attr_name){return attr}}
return!1};var getAttributeOption=function(attr,option){for(var i=0;i<attr.options.length;i++){var attr_option=attr.options[i];if(attr_option.value===option){return attr_option}}
return!1};var active_class='jcaa_active_attr';var disable_class='jcass_attr_disable';var disable_li_class='jcass_attr_disabled';var out_of_stock_class='jcaa_no_stock';var product_variations=$('.variations_form.cart').data('product_variations');var visible_attrs={};if(product_variations!=undefined&&product_variations.length>0){for(var index in product_variations){var row=product_variations[index];if(row.variation_is_visible==!1&&row.variation_is_active==!1&&row.is_purchasable==!1){continue}
for(var attr_key in row.attributes){var attr_val=row.attributes[attr_key];if(visible_attrs[attr_key]==undefined){visible_attrs[attr_key]=[]}
if($.inArray(attr_val,visible_attrs[attr_key])==-1){visible_attrs[attr_key].push(attr_val)}}}}
$('select[name^="attribute_pa_"]').each(function(){var _select=$(this);var _name=$(this).attr('name').substr(10);var _attr=getAttribute(_name);if(_attr!==!1&&_attr.type!=='default'){if(_attr.label==='hide'){_select.parents('tr').find('.label').css('visibility','hidden')}
var classes=''
if(_attr.style==='rounded'&&_attr.type!=='text'){classes+='jcaa_rounded_corners'}
if(_attr.size==='large'){classes+=' jcaa_size_large'}else if(_attr.size==='medium'){classes+=' jcaa_size_medium'}else{classes+=' jcaa_size_small'}
var htmlOutput='';htmlOutput+='<ul id="jcaa_attr_'+_name+'" class="jcaa_attr_select jcaa_attr_variable_select '+classes+'">';_select.find('option').each(function(){if(visible_attrs['attribute_'+_attr.name]!=undefined){var check_attr=visible_attrs['attribute_'+_attr.name];if($.inArray("",check_attr)>-1||$.inArray($(this).val(),check_attr)>-1){var _option=getAttributeOption(_attr,$(this).val());if(_option!==!1){if(_attr.type==='image'){htmlOutput+='<li><img src="'+_option.img+'" alt="'+_option.alt+'" title="'+_option.name+'" data-target="#'+_select.attr('id')+'" data-value="'+_option.value+'" class="jcaa_attr_option jcaa_obj_image" /></li>'}else if(_attr.type==='color'){htmlOutput+='<li><div  data-target="#'+_select.attr('id')+'" title="'+_option.name+'" data-value="'+_option.value+'" class="jcaa_attr_option jcaa_obj_color"><strong class="show_color_varition" style="background: '+_option.color+';" ></strong><span>'+_option.name+'</span></div></li>'}else if(_attr.type==='text'){htmlOutput+='<li><a data-target="#'+_select.attr('id')+'" data-value="'+_option.value+'" title="'+_option.name+'" class="jcaa_attr_option jcaa_obj_text">'+_option.name+'</a></li>'}}}}});htmlOutput+='</ul>';var _value_wrapper=_select.parents('.value');if(_value_wrapper){_value_wrapper.addClass('jcaa_select_enabled')}
_select.after(htmlOutput);_select.hide()}});$('.variations_form.cart .jcaa_attr_select').each(function(){var _attr_list=$(this);_attr_list.find('.jcaa_attr_option').each(function(){var _attr_option=$(this);_attr_option.click(function(event){if($(this).hasClass(disable_class)){return event.preventDefault()}
var _target=_attr_option.data('target');_target=_target.substr(1);_target='[id="'+_target+'"]';var _select_target=$(_target);var _select_value=_attr_option.data('value');if($(_select_target).find('option[value="'+_select_value+'"]').prop("selected")==!0){if(jcaa.enable_attr_toggle=='yes'){$(_select_target).find('option').attr("selected",!1);$(_select_target).find('option:first').attr("selected",!0)}}else{$(_select_target).find('option').attr("selected",!1);$(_select_target).val(_select_value);$(_select_target).find('option[value="'+_select_value+'"]').attr("selected",!0)}
$(_select_target).trigger('change');event.preventDefault()})})});var wc_variation_form_matcher={find_matching_variations:function(product_variations,settings){var matching=[];if(product_variations!=undefined){for(var i=0;i<product_variations.length;i++){var variation=product_variations[i];if(wc_variation_form_matcher.variations_match(variation.attributes,settings)){matching.push(variation)}}}
return matching},variations_match:function(attrs1,attrs2){var match=!0;for(var attr_name in attrs1){if(attrs1.hasOwnProperty(attr_name)){var val1=attrs1[attr_name];var val2=attrs2[attr_name];if(val1!==undefined&&val2!==undefined&&val1.length!==0&&val2.length!==0&&val1!==val2){match=!1}}}
return match}};$.fn.jcaaCheckAttrValidation=function(){var product_variations=$('.variations_form.cart').data('product_variations');var active_attrs=[];var found=!1;var hasEmptyAttr=!1;var active_count=0;var attr_count=0;$('.variations select').each(function(){if($(this).val()!==''){active_count++;found=$(this).attr('name')}else{hasEmptyAttr=!0}
active_attrs[$(this).attr('name')]=$(this).val();attr_count++});$('.jcaa_attr_option').removeClass(disable_class);$('.jcaa_attr_variable_select li').removeClass(out_of_stock_class+' '+disable_li_class);var matching_vars=[];var out_of_stock=[];var stock_levels={};var set_in_stock=function(attributes){for(var attr_name in attributes){if(stock_levels[attr_name]!==undefined&&stock_levels[attr_name]==!0){continue}
var attr_val=attributes[attr_name];if(attr_val===""){stock_levels[attr_name]=!0}else{if(stock_levels[attr_name]===undefined){stock_levels[attr_name]=[]}
if(stock_levels[attr_name].indexOf(attr_val)===-1){stock_levels[attr_name].push(attr_val)}}}};var is_in_stock=function(attribute_name,attribute_val,forced){if(stock_levels[attribute_name]!==undefined){if(stock_levels[attribute_name]===!0){return!0}
if(stock_levels[attribute_name]!==!1){if(stock_levels[attribute_name].indexOf(attribute_val)!==-1){return!0}}}
return!1};var count_check=((attr_count-1)>1)?(attr_count-1):1;var enabled_options={};if(active_count>0){for(var attr_name in active_attrs){var attr_row=[];for(var attr_key in active_attrs){if(attr_name==attr_key){attr_row[attr_key]=""}else{attr_row[attr_key]=active_attrs[attr_key]}}
matching_vars=wc_variation_form_matcher.find_matching_variations(product_variations,attr_row);if(matching_vars.length==0){continue}
for(var i=0;i<matching_vars.length;i++){var variation=matching_vars[i];if(variation.is_in_stock===!1){out_of_stock.push({attribute:attr_name,value:variation.attributes[attr_name],force:!1})}else{set_in_stock(variation.attributes);if(enabled_options[attr_name]==undefined){enabled_options[attr_name]=[]}
if(enabled_options[attr_name]!='*'){if(variation.attributes[attr_name]==""){if(enabled_options[attr_name]==undefined){enabled_options[attr_name]="*"}else{enabled_options[attr_name]="*"}}else if(enabled_options[attr_name].indexOf(variation.attributes[attr_name])===-1){enabled_options[attr_name].push(variation.attributes[attr_name])}}}}}}
for(var attr_k in enabled_options){var enabled_attr=enabled_options[attr_k];var attr_n=attr_k.substr(10);var _jcaa_elem=$('[id="jcaa_attr_'+attr_n+'"]');if(enabled_attr!='*'){_jcaa_elem.find('.jcaa_attr_option').addClass(disable_class).parent().addClass(disable_li_class);for(var i=0;i<enabled_attr.length;i++){var specific_attr=enabled_attr[i];_jcaa_elem.find('.jcaa_attr_option[data-value="'+specific_attr+'"]').removeClass(disable_class).parent().removeClass(disable_li_class)}}}
if(active_count<attr_count){matching_vars=wc_variation_form_matcher.find_matching_variations(product_variations,active_attrs);var set_force=!1;if(active_count==attr_count-1){set_force=!0}
if(matching_vars.length>0){for(var i=0;i<matching_vars.length;i++){var variation=matching_vars[i];if(variation.is_in_stock===!1){var attr_name=found;for(var test_a in variation.attributes){if(variation.attributes[test_a]!==""&&variation.attributes[test_a]!==found){out_of_stock.push({attribute:test_a,value:variation.attributes[test_a],force:set_force})}}}else{set_in_stock(variation.attributes,!0)}}}}
var already_checked={};if(out_of_stock.length>0){for(var i=0;i<out_of_stock.length;i++){var attr_k=out_of_stock[i].attribute;var attr_v=out_of_stock[i].value;if(already_checked[attr_k]===undefined){already_checked[attr_k]={}}
if(is_in_stock(attr_k,attr_v)===!0&&out_of_stock[i].force!==!0){if(already_checked[attr_k][attr_v]===undefined){already_checked[attr_k][attr_v]=!0}
continue}
if(out_of_stock[i].force===!0&&active_attrs[attr_k]!==""){if(already_checked[attr_k][attr_v]===undefined){already_checked[attr_k][attr_v]=!0}
continue}
if(already_checked[attr_k][attr_v]!==undefined){continue}
var attr_n=attr_k.substr(10);var _jcaa_elem=$('[id="jcaa_attr_'+attr_n+'"]');_jcaa_elem.find('.jcaa_attr_option[data-value="'+attr_v+'"]').addClass(disable_class).parent().addClass(out_of_stock_class+' '+disable_li_class)}}};$('body').on('change','.variations select',function(){var _name=$(this).attr('name').substr(10);$('ul[id="jcaa_attr_'+_name+'"] .'+active_class).removeClass(active_class);$('ul[id="jcaa_attr_'+_name+'"] [data-value="'+$(this).val()+'"]').parent().addClass(active_class);if(jcaa.enable_validation!==undefined&&jcaa.enable_validation=='yes'){$.fn.jcaaCheckAttrValidation()}});$('.variations select').trigger('change')})