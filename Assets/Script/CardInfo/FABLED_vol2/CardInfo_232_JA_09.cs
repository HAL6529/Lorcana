using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_232_JA_09 : CardInfo
{
    public CardInfo_232_JA_09()
    {
        this.cardNo = "232_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "アリエル";
        this.cardName2 = "冒険好きな収集家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JoaoMoura;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
