using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_03 : CardInfo
{
    public CardInfo_018_JA_03()
    {
        this.cardNo = "018_JA_03";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "プルート";
        this.cardName2 = "人なつっこいわんこ";
        this.power = 0;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
