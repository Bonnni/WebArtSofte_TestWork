﻿const availableNames = [ "Вячеслав", "Андрей", "Максим", "Сергей", "Даниил", "Олег", "Аркадий", "Иван",
        "Владимир", "Константин", "Кирилл", "Оксана", "Ксения", "Арина", "Анастасия", "Дарья", "Эмма",
        "Анна", "Галина", "Вадим", "Филипп"
];


$("#js-firstName").autocomplete({
        source: availableNames
});

