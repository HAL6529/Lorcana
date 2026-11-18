using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_08 : CardInfo
{
    public CardInfo_097_JA_08()
    {
        this.cardNo = "097_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "チップ";
        this.cardName2 = "機転の利くリス";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianWeisz;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
