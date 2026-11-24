using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_223_JA_12 : CardInfo
{
    public CardInfo_223_JA_12()
    {
        this.cardNo = "223_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジェシー";
        this.cardName2 = "じゃじゃ馬カウガール";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MedusaDollmaker;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Toy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
