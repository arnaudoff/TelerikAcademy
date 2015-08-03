function solve(){
    return function(selector) {
        var $select,
            options,
            $firstOption,
            $current,
            $optionsContainer,
            i,
            $currentOption,
            $currentOptionValue,
            $currentOptionText;

        if (!selector || typeof selector !== 'string') {
            throw new Error('Selector must be a string.');
        }

        $select = $(selector);
        $select.wrap('<div class="dropdown-list"></div>')
            .hide();

        options = $select.children('option');

        $firstOption = $(options[0]);

        $current = $('<div />')
            .addClass('current')
            .text($firstOption.text())
            .attr('data-value', $firstOption.val())
            .insertAfter($select);

        $optionsContainer = $('<div />')
            .addClass('options-container')
            .css('position', 'absolute')
            .hide()
            .insertAfter($current);

        $optionsContainer.on('click', '.dropdown-item', function () {
            var $this = $(this),
                clickedDataValue = $this.attr('data-value');

            $current.text($this.text());
            $current.attr('data-value', clickedDataValue);
            $select.val(clickedDataValue);
            $optionsContainer.hide();
        });

        $current.on('click', function () {
            if ($optionsContainer.css('display') === 'none') {
                $optionsContainer.show();
            }
        });

        for (i = 0; i < options.length; i += 1) {
            $currentOption = $(options[i]);
            $currentOptionValue = $currentOption.val();
            $currentOptionText = $currentOption.text();

            $('<div />')
                .addClass('dropdown-item')
                .attr('data-value', $currentOptionValue)
                .attr('data-index', i)
                .text($currentOptionText)
                .appendTo($optionsContainer);
        }
    };
}

module.exports = solve;