using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_05 : CardInfo
{
    public CardInfo_157_JA_05()
    {
        this.cardNo = "157_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ティポ";
        this.cardName2 = "育ち盛りの息子";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Kapik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
