using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_14 : CardInfo
{
    public CardInfo_022_JA_14()
    {
        this.cardNo = "022_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "グーフィー";
        this.cardName2 = "このバンドの知り合い";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
