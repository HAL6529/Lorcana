using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_097_JA_07 : CardInfo
{
    public CardInfo_097_JA_07()
    {
        this.cardNo = "097_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ヨウカイ";
        this.cardName2 = "知的な策謀家";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DiogoSaito;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
