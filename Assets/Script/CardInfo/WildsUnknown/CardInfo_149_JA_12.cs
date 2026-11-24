using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_149_JA_12 : CardInfo
{
    public CardInfo_149_JA_12()
    {
        this.cardNo = "149_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "エドナ・モード";
        this.cardName2 = "スーパースーツデザイナー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
