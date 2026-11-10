using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_182_JA_04 : CardInfo
{
    public CardInfo_182_JA_04()
    {
        this.cardNo = "182_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ÉäÅ[ÅEÉVÉÉÉì";
        this.cardName2 = "çcåRë‡í∑";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
