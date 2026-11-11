using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_174_JA_05 : CardInfo
{
    public CardInfo_174_JA_05()
    {
        this.cardNo = "174_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ルディー";
        this.cardName2 = "グルーヴ・ストッパー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JonDenskAndHayleyEvans;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
