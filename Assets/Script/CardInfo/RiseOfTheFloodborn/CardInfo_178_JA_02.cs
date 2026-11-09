using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_178_JA_02 : CardInfo
{
    public CardInfo_178_JA_02()
    {
        this.cardNo = "178_JA_02";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "深海ダイバー";
        this.power = 6;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
