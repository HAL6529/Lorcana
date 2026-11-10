using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_024_JA_02 : CardInfo
{
    public CardInfo_024_JA_02()
    {
        this.cardNo = "024_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "îíê·ïP";
        this.cardName2 = "évÇ¢Ç™ÇØÇ»Ç¢ìØãèêl";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
