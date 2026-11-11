using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_105_JA_05 : CardInfo
{
    public CardInfo_105_JA_05()
    {
        this.cardNo = "105_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "マキシマス";
        this.cardName2 = "本命チーム";
        this.power = 3;
        this.toughness = 5;
        this.lore =21;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
