using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_05 : CardInfo
{
    public CardInfo_114_JA_05()
    {
        this.cardNo = "114_JA_05";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "タフィタ・マトンファッジ";
        this.cardName2 = "大人気レーサー";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarlosLuzzi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
