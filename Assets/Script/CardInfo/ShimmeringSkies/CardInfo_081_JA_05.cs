using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_081_JA_05 : CardInfo
{
    public CardInfo_081_JA_05()
    {
        this.cardNo = "081_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "エド";
        this.cardName2 = "ヒステリックなパーティー客";
        this.power = 2;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
