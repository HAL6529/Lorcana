using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_05 : CardInfo
{
    public CardInfo_209_JA_05()
    {
        this.cardNo = "209_JA_05";
        this.inkCost = 9;
        this.availableInk = false;
        this.cardName1 = "ÉIÉâÉt";
        this.cardName2 = "Ç≤Ç´Ç∞ÇÒÇ»èÊãq";
        this.power = 6;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
