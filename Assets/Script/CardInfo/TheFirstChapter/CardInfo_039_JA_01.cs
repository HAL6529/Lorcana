using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_039_JA_01 : CardInfo
{
    public CardInfo_039_JA_01()
    {
        this.cardNo = "039_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉtÉ@ÉVÉäÉG";
        this.cardName2 = "ëfê∞ÇÁÇµÇ¢êaém";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Cam Kendell";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
