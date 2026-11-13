using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_07 : CardInfo
{
    public CardInfo_140_JA_07()
    {
        this.cardNo = "140_JA_07";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ライル・ティベリウス・ローク";
        this.cardName2 = "硬化した雇われ兵";
        this.power = 6;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
