using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_014_JA_08 : CardInfo
{
    public CardInfo_014_JA_08()
    {
        this.cardNo = "014_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "パディータ";
        this.cardName2 = "見張りの番犬";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
