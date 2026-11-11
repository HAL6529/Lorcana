using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_05 : CardInfo
{
    public CardInfo_156_JA_05()
    {
        this.cardNo = "156_JA_05";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "タナナ";
        this.cardName2 = "知恵ある女";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.BrotherBear;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
