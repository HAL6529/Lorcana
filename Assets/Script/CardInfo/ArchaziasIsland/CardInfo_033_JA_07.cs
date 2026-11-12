using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_033_JA_07 : CardInfo
{
    public CardInfo_033_JA_07()
    {
        this.cardNo = "033_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "îíê·ïP";
        this.cardName2 = "Ç±ÇÃê¢Ç≈ç≈çÇÇÃî¸ÇµÇ≥";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarioManzanares;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
