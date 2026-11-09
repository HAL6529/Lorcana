using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_04 : CardInfo
{
    public CardInfo_024_JA_04()
    {
        this.cardNo = "024_JA_04";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "アースラ";
        this.cardName2 = "エリックの花嫁";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Princess, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.ShiftDiscardAnSongCard };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
