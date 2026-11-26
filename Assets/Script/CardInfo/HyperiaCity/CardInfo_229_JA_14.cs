using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_229_JA_14 : CardInfo
{
    public CardInfo_229_JA_14()
    {
        this.cardNo = "229_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "マックス・グーフ";
        this.cardName2 = "カラオケ・スター";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KendallHale;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
