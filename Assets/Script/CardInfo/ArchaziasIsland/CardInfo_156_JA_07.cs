using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_156_JA_07 : CardInfo
{
    public CardInfo_156_JA_07()
    {
        this.cardNo = "156_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒ‚ƒAƒi";
        this.cardName2 = "—¤‚ÆŠC‚Ì–`Œ¯ŽÒ";
        this.power = 1;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AnnaStosik;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
