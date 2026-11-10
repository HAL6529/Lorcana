using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_03 : CardInfo
{
    public CardInfo_172_JA_03()
    {
        this.cardNo = "172_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "イーヨー";
        this.cardName2 = "ぎゅうぎゅう詰めのロバ";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
