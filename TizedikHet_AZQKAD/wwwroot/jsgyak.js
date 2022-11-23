for (var sor = 0; sor < 10; sor++) {
    //új div létrehozása az új sornak
    //új div osztálylistájához add hozzá a "sor"-t
    //új div-et add hozzá a "pascal" gyermekeihez
    for (var oszlop = 0; oszlop <= sor; oszlop++) {
        //új div létrehozása az új elemnek
        //új elem div osztálylistájához add hozzá az "elem"-et
        //teszteléshet .innerHTML = `${sor}:${oszlop}`
        //legyen az innerHTML a megfelelő szám
        //új elem div-et vedd fel a sor elemei közé
    }
}

var faktoriális = function (n) {
    let er = 1;
    for (let i = 2; i <= n; i++) {
        er = er * i;
    }
    return er;
}