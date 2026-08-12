using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_01 : CardInfo
{
    public CardInfo_052_JA_01()
    {
        this.cardNo = "052_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉIÉâÉt";
        this.cardName2 = "êlâ˘Ç¡Ç±Ç¢ê·ÇæÇÈÇ‹";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Gulia Riva";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
