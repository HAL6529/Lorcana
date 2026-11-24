using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_12 : CardInfo
{
    public CardInfo_057_JA_12()
    {
        this.cardNo = "057_JA_12";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "モルデュー";
        this.cardName2 = "猛獣に堕した王子";
        this.power = 8;
        this.toughness = 8;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
