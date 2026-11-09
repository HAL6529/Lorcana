using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_155_JA_03 : CardInfo
{
    public CardInfo_155_JA_03()
    {
        this.cardNo = "155_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スクルージ・マクダック";
        this.cardName2 = "金持ち伯父さん";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.StefanoZanchi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
