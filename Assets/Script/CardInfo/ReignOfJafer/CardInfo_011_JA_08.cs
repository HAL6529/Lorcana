using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_08 : CardInfo
{
    public CardInfo_011_JA_08()
    {
        this.cardNo = "011_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "レディ";
        this.cardName2 = "家族の犬";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.ErikaWiseman;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LadyAndTheTramp;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
