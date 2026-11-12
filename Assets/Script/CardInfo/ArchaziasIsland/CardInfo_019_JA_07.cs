using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_019_JA_07 : CardInfo
{
    public CardInfo_019_JA_07()
    {
        this.cardNo = "019_JA_07";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "パスカル";
        this.cardName2 = "花壇のカメレオン";
        this.power = 3;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
