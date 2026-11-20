using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_237_JA_09 : CardInfo
{
    public CardInfo_237_JA_09()
    {
        this.cardNo = "237_JA_09";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ハデス";
        this.cardName2 = "冥府の策謀家";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LadyShalirin;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
