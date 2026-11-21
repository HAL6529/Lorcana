using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_223_JA_09 : CardInfo
{
    public CardInfo_223_JA_09()
    {
        this.cardNo = "223_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ポンゴ";
        this.cardName2 = "決意の父犬";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
