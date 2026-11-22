using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_212_JA_10 : CardInfo
{
    public CardInfo_212_JA_10()
    {
        this.cardNo = "212_JA_10";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "カー";
        this.cardName2 = "秘密主義のヘビ";
        this.power = 6;
        this.toughness = 7;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
