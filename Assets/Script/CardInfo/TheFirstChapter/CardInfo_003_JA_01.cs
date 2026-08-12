using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_01 : CardInfo
{
    public CardInfo_003_JA_01()
    {
        this.cardNo = "003_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒVƒ“ƒfƒŒƒ‰";
        this.cardName2 = "–Y‚ê‚È‚¢—D‚µ‚³";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Javier Salas";
        this.classList = new List<EnumController.Class> { EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Singer5 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
