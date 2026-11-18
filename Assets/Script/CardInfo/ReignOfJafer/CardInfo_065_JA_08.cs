using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_065_JA_08 : CardInfo
{
    public CardInfo_065_JA_08()
    {
        this.cardNo = "065_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ネロ";
        this.cardName2 = "恐るべきワニ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.TeresitaQAndSCG;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheRescuers;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
