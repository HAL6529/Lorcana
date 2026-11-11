using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_079_JA_05 : CardInfo
{
    public CardInfo_079_JA_05()
    {
        this.cardNo = "079_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "イアーゴ";
        this.cardName2 = "ニセモンのフラミンゴ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HadjieJoosAndPixSmith;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
