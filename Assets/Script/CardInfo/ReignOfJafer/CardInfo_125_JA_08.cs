using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_08 : CardInfo
{
    public CardInfo_125_JA_08()
    {
        this.cardNo = "125_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ブルータス";
        this.cardName2 = "恐るべきワニ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TeresitaQAndSCG;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
