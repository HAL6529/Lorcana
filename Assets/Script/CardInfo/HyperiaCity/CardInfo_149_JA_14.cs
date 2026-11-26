using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_14 : CardInfo
{
    public CardInfo_149_JA_14()
    {
        this.cardNo = "149_JA_14";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "手堅い投資家";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmandaDuarte;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
