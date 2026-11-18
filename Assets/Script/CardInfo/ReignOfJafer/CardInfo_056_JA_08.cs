using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_08 : CardInfo
{
    public CardInfo_056_JA_08()
    {
        this.cardNo = "056_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ライダー";
        this.cardName2 = "すばしっこい潜入者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LisanneKoeteeuw;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
