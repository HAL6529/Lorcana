using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_08 : CardInfo
{
    public CardInfo_019_JA_08()
    {
        this.cardNo = "019_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "プア";
        this.cardName2 = "番豚";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlexandriaNeonakis;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
