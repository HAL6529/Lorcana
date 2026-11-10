using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_218_JA_03 : CardInfo
{
    public CardInfo_218_JA_03()
    {
        this.cardNo = "218_JA_03";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "スクルージ・マクダック";
        this.cardName2 = "世界一の金持ちアヒル";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
