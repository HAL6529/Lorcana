using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_074_JA_07 : CardInfo
{
    public CardInfo_074_JA_07()
    {
        this.cardNo = "074_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "èóâ§";
        this.cardName2 = "ìiÇ›ê[Ç¢î¸èó";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
