using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_214_JA_06 : CardInfo
{
    public CardInfo_214_JA_06()
    {
        this.cardNo = "214_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ラーヤ";
        this.cardName2 = "クマンドラの騎手";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
