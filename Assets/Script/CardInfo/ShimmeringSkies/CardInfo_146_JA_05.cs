using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_05 : CardInfo
{
    public CardInfo_146_JA_05()
    {
        this.cardNo = "146_JA_05";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "チチャ";
        this.cardName2 = "献身的な母親";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
