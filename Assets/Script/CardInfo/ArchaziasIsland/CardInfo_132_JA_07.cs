using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_132_JA_07 : CardInfo
{
    public CardInfo_132_JA_07()
    {
        this.cardNo = "132_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ビーグルボーイズ";
        this.cardName2 = "ちんけな悪党ども";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LaurenBarger;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
