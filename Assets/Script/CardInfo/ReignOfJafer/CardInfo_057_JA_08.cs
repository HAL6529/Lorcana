using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_08 : CardInfo
{
    public CardInfo_057_JA_08()
    {
        this.cardNo = "057_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "バンビ";
        this.cardName2 = "森の王子さま";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
