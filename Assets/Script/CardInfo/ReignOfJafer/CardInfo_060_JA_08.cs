using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_060_JA_08 : CardInfo
{
    public CardInfo_060_JA_08()
    {
        this.cardNo = "060_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "エルサ";
        this.cardName2 = "猛吹雪の守護者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
